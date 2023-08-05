using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System59 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component463> _p1;
EcsPool<Component406> _p2;
EcsPool<Component286> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component463>().Inc<Component406>().Inc<Component286>().End();
   _p1 = _world.GetPool<Component463>();
   _p2 = _world.GetPool<Component406>();
   _p3 = _world.GetPool<Component286>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

}
