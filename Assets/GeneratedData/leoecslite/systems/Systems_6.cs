using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System6 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component396> _p1;
EcsPool<Component197> _p2;
EcsPool<Component125> _p3;
EcsPool<Component196> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component396>().Inc<Component197>().Inc<Component125>().Inc<Component196>().End();
   _p1 = _world.GetPool<Component396>();
   _p2 = _world.GetPool<Component197>();
   _p3 = _world.GetPool<Component125>();
   _p4 = _world.GetPool<Component196>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

}
