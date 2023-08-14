using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System130 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component409> _p1;
EcsPool<Component217> _p2;
EcsPool<Component298> _p3;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component409>().Inc<Component217>().Inc<Component298>().End();
   _p1 = _world.GetPool<Component409>();
   _p2 = _world.GetPool<Component217>();
   _p3 = _world.GetPool<Component298>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

}
