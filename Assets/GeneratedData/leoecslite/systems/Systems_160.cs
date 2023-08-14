using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System160 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component167> _p1;
EcsPool<Component257> _p2;
EcsPool<Component492> _p3;
EcsPool<Component6> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component167>().Inc<Component257>().Inc<Component492>().Inc<Component6>().End();
   _p1 = _world.GetPool<Component167>();
   _p2 = _world.GetPool<Component257>();
   _p3 = _world.GetPool<Component492>();
   _p4 = _world.GetPool<Component6>();
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
