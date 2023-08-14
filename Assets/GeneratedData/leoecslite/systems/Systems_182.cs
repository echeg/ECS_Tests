using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System182 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component453> _p1;
EcsPool<Component440> _p2;
EcsPool<Component376> _p3;
EcsPool<Component183> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component453>().Inc<Component440>().Inc<Component376>().Inc<Component183>().End();
   _p1 = _world.GetPool<Component453>();
   _p2 = _world.GetPool<Component440>();
   _p3 = _world.GetPool<Component376>();
   _p4 = _world.GetPool<Component183>();
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
