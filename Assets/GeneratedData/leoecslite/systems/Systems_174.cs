using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System174 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component298> _p1;
EcsPool<Component300> _p2;
EcsPool<Component317> _p3;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component298>().Inc<Component300>().Inc<Component317>().End();
   _p1 = _world.GetPool<Component298>();
   _p2 = _world.GetPool<Component300>();
   _p3 = _world.GetPool<Component317>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

}
