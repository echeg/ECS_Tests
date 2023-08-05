using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System30 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component204> _p1;
EcsPool<Component90> _p2;
EcsPool<Component203> _p3;
EcsPool<Component444> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component204>().Inc<Component90>().Inc<Component203>().Inc<Component444>().End();
   _p1 = _world.GetPool<Component204>();
   _p2 = _world.GetPool<Component90>();
   _p3 = _world.GetPool<Component203>();
   _p4 = _world.GetPool<Component444>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

}
