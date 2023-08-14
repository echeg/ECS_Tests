using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System93 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component439> _p1;
EcsPool<Component173> _p2;
EcsPool<Component303> _p3;
EcsPool<Component151> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component439>().Inc<Component173>().Inc<Component303>().Inc<Component151>().End();
   _p1 = _world.GetPool<Component439>();
   _p2 = _world.GetPool<Component173>();
   _p3 = _world.GetPool<Component303>();
   _p4 = _world.GetPool<Component151>();
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
