using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System39 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component316> _p1;
EcsPool<Component415> _p2;
EcsPool<Component36> _p3;
EcsPool<Component15> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component316>().Inc<Component415>().Inc<Component36>().Inc<Component15>().End();
   _p1 = _world.GetPool<Component316>();
   _p2 = _world.GetPool<Component415>();
   _p3 = _world.GetPool<Component36>();
   _p4 = _world.GetPool<Component15>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

}
