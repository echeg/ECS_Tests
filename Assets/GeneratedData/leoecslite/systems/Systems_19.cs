using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System19 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component254> _p1;
EcsPool<Component88> _p2;
EcsPool<Component127> _p3;
EcsPool<Component263> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component254>().Inc<Component88>().Inc<Component127>().Inc<Component263>().End();
   _p1 = _world.GetPool<Component254>();
   _p2 = _world.GetPool<Component88>();
   _p3 = _world.GetPool<Component127>();
   _p4 = _world.GetPool<Component263>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

}
