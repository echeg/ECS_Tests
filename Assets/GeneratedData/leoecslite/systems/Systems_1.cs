using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System1 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component80> _p1;
EcsPool<Component228> _p2;
EcsPool<Component22> _p3;
EcsPool<Component446> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component80>().Inc<Component228>().Inc<Component22>().Inc<Component446>().End();
   _p1 = _world.GetPool<Component80>();
   _p2 = _world.GetPool<Component228>();
   _p3 = _world.GetPool<Component22>();
   _p4 = _world.GetPool<Component446>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

}
