using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System103 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component446> _p1;
EcsPool<Component486> _p2;
EcsPool<Component71> _p3;
EcsPool<Component100> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component446>().Inc<Component486>().Inc<Component71>().Inc<Component100>().End();
   _p1 = _world.GetPool<Component446>();
   _p2 = _world.GetPool<Component486>();
   _p3 = _world.GetPool<Component71>();
   _p4 = _world.GetPool<Component100>();
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
